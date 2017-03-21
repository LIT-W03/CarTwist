$(function () {
    $("#car-type").on('change', function() {
        var value = $("#car-type option:selected").val();
        if (value === "2") {
            $("#has-leather").attr('disabled', true);
            $('#has-leather').val('true');
        } else {
            $("#has-leather").attr('disabled', false);
        }
    });
});