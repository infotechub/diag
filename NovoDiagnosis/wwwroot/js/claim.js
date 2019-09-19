var dataTable;
$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "https://localhost:44305/api/Claims1/GetAll",
            "type": "GET",
            "datatype": "Json"
        },
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "enrolleeFullname", "width": "10%" },
            { "data": "enrolleePolicyNumber", "width": "10%" },
            { "data": "enrolleeCompanyName", "width": "10%" },
            { "data": "serviceDate", "width": "10%" },
            { "data": "diagnosis", "width": "10%" },
            { "data": "status", "width": "10%" },
            { "data": "createdOn", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                     <a href="/hub/claim/upsert/${data}" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-edit'></i> Edit
                                </a>
                                &nbsp;
                                <a onclick=Delete("/dub/claim/delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-trash-alt'></i> Delete
                                </a>
                            </div>
                            `;
                }, "width": "20%"
            }

        ],
        "language": {
            "emptyTable": "No categories found."
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want to delete this category?",
        text: "NOTE: You will not be able to restore this category!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete it!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}