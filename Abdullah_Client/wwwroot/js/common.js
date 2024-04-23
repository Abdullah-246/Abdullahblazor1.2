
window.showToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Operation Successful', { timeout: 5000 });
    }
    if (type === "error") {
        toastr.error(message, 'Operation Failed', { timeout: 5000 });
    }
}

window.showSwal = (type, message) => {
    if (type === "success") {
        Swal.fire({
            title: "Success Notification!",
            message,
            icon: "success"
        });
    }
    if (type === "error") {
        Swal.fire({
            title: "Error Notification!",
            message,
            icon: "error"
        });
    }
}

function ShowDeleteConfirmationModel() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModel() {
    $('#deleteConfirmationModal').modal('hide');
}
