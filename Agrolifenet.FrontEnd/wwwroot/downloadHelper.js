window.downloadFile = function (base64Data, fileName) {
    var link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + base64Data;
    link.download = fileName;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};