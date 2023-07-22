$(function () {
  const memberCards = $(".member-card");

  for (let i = 0; i < memberCards.length; i++) {
    const modalId = "modal_" + memberCards.eq(i).attr("data-index");
    memberCards.eq(i).on("click", () => {
      ToggleModal($("#famTree"), $(`#${modalId}`), openModal);
      $("#famTree").removeClass("unclickable");
    });

    const closeBtnId = "closeBtn_" + memberCards.eq(i).attr("data-index");
    $(`#${closeBtnId}`).on("click", () => {
      ToggleModal($("#famTree"), $(`#${modalId}`), closeModal);
    });

  }

});
