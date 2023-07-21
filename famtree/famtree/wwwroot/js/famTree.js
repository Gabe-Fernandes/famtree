$(function () {
  const memberCards = $(".member-card");

  for (let i = 0; i < memberCards.length; i++) {
    memberCards.eq(i).on("click", () => {
      const modalId = "modal_" + memberCards.eq(i).attr("data-index");
      ToggleModal($("#famTree"), $(`#${modalId}`), openModal);
    });
  }
});
