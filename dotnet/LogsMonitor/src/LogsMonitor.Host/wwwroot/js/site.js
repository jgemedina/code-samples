// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    let $logTable = $("div.x-container-table table.x-table-logs");

    if ($logTable.length == 0) {
        return;
    }
    
    console.debug("Table element acquired");

    let $tableBody = $logTable.find("tbody");
    if ($tableBody.length == 0) {
        return;
    }

    $.get('/activitylogs/index2', function(response) {
        console.debug(response);

        let responseData = response;
        $.each(responseData, function(i) {
            let { eventTimestamp: eventTs, systemArea, userAction, userIdentity } = responseData[i];
            $tableBody.append(`<tr>\
            <td>${eventTs}</td>\
            <td>${userIdentity}</td>\
            <td>${systemArea}</td>\
            <td>${userAction}</td>\
            </tr>`);
        });
    }, 'json')
    .fail(function (error) {
        $tableBody.html("<tr><td colspan='5'>Could not retrieve content, try again in a moment.</td></tr>")
        console.debug(error);
    });
});