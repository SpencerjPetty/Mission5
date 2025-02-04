$(document).ready(function () {
    $("#calculate").click(function () {
        let hours = parseFloat($("#hours").val());
        let rate = parseFloat($("#rate").val());

        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid positive number for hours.");
            return;
        }

        let total = hours * rate;
        $("#total").val(total.toFixed(2));
    });
});
