$(function () {
    $.get('/my-solution-api/feature/generic-callout', function (response) {
        console.log(response);
    });
});