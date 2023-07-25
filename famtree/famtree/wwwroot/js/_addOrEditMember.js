$(function () {
  function refreshListItemEvents() {
    $(".del-inputs").off("click.delInputs");
    $(".del-input").on("click.delInputs", (event) => {
      $(event.target).parent(".list-item-wrap").remove();
    });

    $(".list-item-wrap").off("dragstart");
    $(".list-item-wrap").off("dragend");
    $(".list-item-wrap").on("dragstart", (event) => {
      $(event.target).addClass(`${$(event.target).children("input").attr("placeholder")}-dragging`);
    });
    $(".list-item-wrap").on("dragend", (event) => {
      $(event.target).removeClass(`${$(event.target).children("input").attr("placeholder") }-dragging`);
    });
  }

  // populate input element with string arr data as single string to send to server
  $("#famMemberForm").on("submit", () => {
    $("#sendChildrenToServer").val(generateDataString($(".list-item-wrap").children("input"), "child"));
    $("#sendCitiesToServer").val(generateDataString($(".list-item-wrap").children("input"), "city"));
    $("#sendInterestsToServer").val(generateDataString($(".list-item-wrap").children("input"), "interest"));
    $("#sendLanguagesToServer").val(generateDataString($(".list-item-wrap").children("input"), "language"));
  });

  function generateDataString(inputs, inputType) {
    let dataString = "";
    const delimiter = $("#dataFromServer").attr("data-delimiter");

    for (let i = 0; i < inputs.length; i++) {
      if (inputs.eq(i).attr("placeholder") === inputType && inputs.eq(i).val() !== "") {
        dataString += inputs.eq(i).val() + delimiter;
      }
    }
    return dataString;
  }

  // Has passed checkbox
  $("#isAliveCheckbox").on("change", (event) => {
    if ($(event.target).is(":checked")) {
      $("#DOP").addClass("disable");
    } else {
      $("#DOP").removeClass("disable");
    }
  });

  // drag and drop
  function dragContainerEvents(container, draggingClass) {
    container.on("dragover", (event) => {
      event.preventDefault();
      const dropPlacement = getDropPlacement(container[0], event.clientY, draggingClass);
      const draggableItem = document.querySelector(`.${draggingClass}`);
      if (dropPlacement == null) {
        container[0].appendChild(draggableItem);
      }
      else {
        container[0].insertBefore(draggableItem, dropPlacement);
      }
    });
  }

  function getDropPlacement(container, mouseY, draggingClass) {
    // an array of all draggable elements in the container that aren't currently being dragged
    const draggableElements = [...container.querySelectorAll(`.draggable:not(.${draggingClass})`)];

    return draggableElements.reduce((closest, child) => {
      const box = child.getBoundingClientRect();
      const offset = mouseY - box.top - box.height / 2;
      if (offset < 0 && offset > closest.offset) {
        return { offset: offset, element: child }
      }
      else {
        return closest;
      }
    }, { offset: Number.NEGATIVE_INFINITY }).element;
  }

  // initialize events
  refreshListItemEvents();

  $(".add-input").on("click", (event) => {
    $(event.target).parent().next().append(`
      <div class="list-item-wrap draggable" draggable="true">
        <input type="text" placeholder="${$(event.target).attr("data-placeholder")}" />
        <img tabindex="0" src="/icons/X_512x512.png" class="del-input" />
      </div>
    `);
    refreshListItemEvents();
  });

  dragContainerEvents($(".child-drag-container"), "child-dragging");
  dragContainerEvents($(".city-drag-container"), "city-dragging");
  dragContainerEvents($(".interest-drag-container"), "interest-dragging");
  dragContainerEvents($(".language-drag-container"), "language-dragging");
});
