$(window).on("load", function () {
    $.ajax({
        url: 'https://localhost:7042/api/GetAll',
        type: 'GET',     
        success: function (response) {
            // Handle the response
            console.log(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // Handle any errors
            console.error(errorThrown);
        }
    });
});


{
    return Json(cascadingData.ListAll(), JsonRequestBehavior.AllowGet);
}
However, it's generally recommended to avoid allowing GET requests for JSON results to improve security.





