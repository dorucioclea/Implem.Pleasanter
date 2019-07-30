﻿$p.getColumnName = function (name) {
    var data = JSON.parse($('#Columns').val()).filter(function (column) {
        return column.LabelText === name || column.ColumnName === name
    });
    return data.length > 0
        ? data[0].ColumnName
        : undefined;
}

$p.getControl = function (name) {
    var columnName = $p.getColumnName(name);
    return columnName !== undefined
        ? $('#' + $('#ReferenceType').val() + '_' + columnName)
        : undefined;
}

$p.getGridRow = function (id) {
    return $('#Grid > tbody > tr[data-id="' + id + '"]');
}

$p.getGridCell = function (id, name, excludeHistory) {
    return $('#Grid > tbody > tr[data-id="' + id + '"]' + (excludeHistory? ':not([data-history])' : '') + ' td:nth-child(' + ($p.getGridColumnIndex(name) + 1) + ')');
}

$p.getGridColumnIndex = function (name) {
    return $('#Grid > thead > tr > th').index($('#Grid > thead > tr > th[data-name="' + $p.getColumnName(name) + '"]'));
}