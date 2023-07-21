$(document).ready(function () {
    loadData()
    //$('#button').click(function () {
    //    GetById();
    //});

    //$('#sortButton').click(function () {
    //    sortTable();
    //});
})
function loadData() {
    $.ajax({
        url: "/CascadingData/List",
        type: "GET",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + (key + 1) + '</td>';
                html += '<td>' + item.countryId + '</td>';
                html += '<td>' + item.countryName + '</td>';
                html += '<td>' + item.stateName + '</td>';
                html += '<td>' + item.cityName + '</td>';
                html += '</tr>';
            });

            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function GetById() {
    var inputId = $('#inputId').val();
    console.log(inputId);

    $.ajax({
        url: "/CascadingData/GetAllById?id=" + inputId,
        type: "GET",
        success: function (response) {
            var html = '';
            var recordCount;

            try {
                recordCount = response.length;
                $('.table').show();
            } catch (error) {
                console.error('Error:', error);
                $('.resultCount').text('No records found');
                $('.recordCountText').show();
                $(".table").hide();
                return;
            }

            var recordCountText = recordCount > 0 ? recordCount + ' records found' : 'No records found';
            $('.resultCount').text(recordCountText);
            $('.recordCountText').show();

            $.each(response, function (key, response) {
                html += '<tr>';
                html += '<td>' + (key + 1) + '</td>';
                html += '<td>' + response.countryId + '</td>';
                html += '<td>' + response.countryName + '</td>';
                html += '<td>' + (response.stateName || '') + '</td>';
                html += '<td>' + (response.cityName || '') + '</td>';
                html += '</tr>';
            });
            $('.tbody').html(html);

        },
        error: function () {
            alert("Error retrieving data from the server.");
        }
    });
}

//function GetById() {
//    var inputId = $('#inputId').val();
//    console.log(inputId)

//    $.ajax({
//        url: "/CascadingData/GetAllbyID?id=" + inputId,
//        type: "GET",
//        success: function (response) {
//            var html = '';
//            var recordCount;

//            try {
//                recordCount = response[0].record;
//                $('.table').show();// Get the value of the 'Record' column from the first record
//            } catch (error) {
//                console.error('Error:', error);
//                $('.resultCount').text('No records found');
//                $('.recordCountText').show();
//                $(".table").hide();
//                return; // Stop further execution of the code
//            }

//            var recordCountText = recordCount > 0 ? recordCount + ' records found' : 'No records found';
//            $('.resultCount').text(recordCountText);
//            $('.recordCountText').show();
//            //$('.table').show();

//            var html = '';
//            $.each(response, function (key, response) {
//                html += '<tr>';
//                html += '<td>' + (key + 1) + '</td>';
//                html += '<td>' + response.countryId + '</td>';
//                html += '<td>' + response.countryName + '</td>';
//                html += '<td>' + response.stateName + '</td>';
//                html += '<td>' + response.cityName + '</td>';
//                html += '</tr>';
//            });
//            $('.tbody').html(html);

//        },
//        error: function () {
//            alert("Error retrieving data from the server.");
//        }
//    });
//}

$(document).ready(function () {
    $("th").each(function (column) {
        $(this).hover(function () {
            $(this).data("type", $(this).attr("class"));
            $(this).addClass("clickable");
        }, function () {
            $(this).removeClass("clickable");
        });
        $(this).click(function () {
            var type = $(this).data("type");
            var records = $("table").find("tbody > tr");

            records.sort(function (a, b) {
                var value1 = $(a).children("td").eq(column).text();
                var value2 = $(b).children("td").eq(column).text();
                if (type == "num") {
                    value1 *= 1;
                    value2 *= 1;
                }
                return (value1 < value2) ? -1 : (value1 > value2 ? 1 : 0)
            });
            $.each(records, function (index, row) {
                $("tbody").append(row);
            });
        });
    });
}


);

//function sortTable() {
//    var rows = $('.tbody tr').get();
//    rows.sort(function (a, b) {
//        var countryNameA = $(a).children("td:eq(2)").text().toLowerCase();
//        var countryNameB = $(b).children("td:eq(2)").text().toLowerCase();

//        if (countryNameA < countryNameB) return -1;
//        if (countryNameA > countryNameB) return 1;
//        return 0;
//    });

//    $.each(rows, function (index, row) {
//        $('.tbody').append(row);
//    });
//};


//$(document).ready(function () {
//    $("#inputId").on("keyup", function () {
//        var value = $(this).val().toLowerCase();
//        $(".tbody tr").filter(function () {
//            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
//        });
//    });
//});