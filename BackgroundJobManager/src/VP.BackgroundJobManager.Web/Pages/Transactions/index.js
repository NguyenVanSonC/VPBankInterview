$(function () {
    var inputAction = function (requestData, dataTableSettings) {
        return {
            id: $('#Id').val(),
            name: $('#Name').val(),
        };
    };

    var responseCallback = function (result) {

        // your custom code.

        return {
            recordsTotal: result.totalCount,
            recordsFiltered: result.totalCount,
            data: result.items
        };
    };

    var dataTable = $('#TransactionsTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        ajax: abp.libs.datatables.createAjax(vp.transactionManager.transaction.getList, inputAction, responseCallback),
        columnDefs: [
            { data: "accountNumber" },
            {
                data: "amount",
                render: function (data) {
                    return data.toLocaleString('VI', {
                        style: 'currency',
                        currency: 'VND',
                    });
                }
            },
            { data: "description" },
            {
                data: "creationTime",
                render: function (data) {
                    return luxon
                        .DateTime
                        .fromISO(data, {
                            locale: abp.localization.currentCulture.name
                        }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                }
            },
        ]
    }));
})