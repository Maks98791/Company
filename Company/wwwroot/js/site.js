function confirmDelete(userId, isDeleteClicked) {
    var deleteButtonId = 'deleteUser_' + userId;
    var confirmButtonsId = 'confirmationButtons_' + userId;

    if (isDeleteClicked == true) {
        $('#' + deleteButtonId).hide();
        $('#' + confirmButtonsId).show();
    }
    else {
        $('#' + deleteButtonId).show();
        $('#' + confirmButtonsId).hide();
    }
}