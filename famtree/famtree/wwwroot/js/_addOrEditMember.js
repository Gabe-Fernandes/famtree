$(function () {
  function refreshDelEvents() {
    $(".del-inputs").off("click.delInputs");
    $(".del-input").on("click.delInputs", (event) => {
      $(event.target).parent(".list-item-wrap").remove();
    });
  }
  // initialize delete/add btn events
  refreshDelEvents();

  $(".add-input").on("click", (event) => {
    $(event.target).parent().next().append(`
      <div class="list-item-wrap">
        <input type="text" placeholder="${$(event.target).attr("data-placeholder")}" />
        <img tabindex="0" src="/icons/X_512x512.png" class="del-input" />
      </div>
    `);
    refreshDelEvents();
  });



  // populate input element with string arr data as single string to send to server
  $("#famMemberForm").on("submit", () => {
    $("#sendChildrenToServer").val(generateDataString($(".list-item-wrap").children("input"), "children"));
    $("#sendCitiesToServer").val(generateDataString($(".list-item-wrap").children("input"), "cities lived in"));
    $("#sendInterestsToServer").val(generateDataString($(".list-item-wrap").children("input"), "interests"));
    $("#sendLanguagesToServer").val(generateDataString($(".list-item-wrap").children("input"), "languages spoken"));
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
});
