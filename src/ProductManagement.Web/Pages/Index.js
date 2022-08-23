$(function () {
    abp.log.debug('Index.js initialized!');
    var createModal = new abp.ModalManager(abp.appPath +
        'Products/CreateProductModal');
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    $('#NewProductButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
