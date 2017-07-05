//Add the first function that is independant of the DOM

$(document).ready(function () {

    function GetDataBySelector(selector) {

        var dataArray = [];

        //Gather all my data using the selector
        $(selector).each(function () {
            dataArray.push($(this).val());
        });

        return dataArray;
    }










});