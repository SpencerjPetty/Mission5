$(document).ready(function () { // Wait for the DOM to be ready
    $("#calculate").click(function () {
        let hours = parseFloat($("#hours").val());
        let rate = parseFloat($("#rate").val());
        // Validate input
        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid positive number for hours.");
            return;
        }
        // Make the calculation
        let total = hours * rate;
        $("#total").val(total.toFixed(2));
    });
});
