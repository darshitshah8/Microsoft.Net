
function ViewUser() {

    var userData = {
        username: $("#UserName").val(),
        password: $("#Password").val(),
    };
    $(".validation-error").remove();
    $(".is-invalid").removeClass("is-invalid");

    if (userData.username === "") {
        $("<div class='invalid-feedback'>Please enter a username.</div>").insertAfter($("#UserName"));
        $("#UserName").addClass("is-invalid");
        return;
    }

    if (userData.password === "") {
        $("<div class='invalid-feedback'>Please enter a password.</div>").insertAfter($("#Password"));
        $("#Password").addClass("is-invalid");
        return;
    }
    $.ajax({
        url: "/Home/ViewAccount",
        data: userData,
        type: "GET",

        success: function (result) {
            console.log(result);    
            if (result == true) {
                if (window.location.pathname === '/Home/Home') {
                    window.location.href = '/Home/Home';
                } else {
                    window.location.href = window.location.pathname;
                }
                $("#Password").val("");
                $("#UserName").val("");
            } else {
                $("<div class='invalid-feedback'>username and password are not match</div>").insertAfter($("#Password"));
                $("#Password").addClass("is-invalid");
                $("#UserName").addClass("is-invalid");
            }

            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });     
}
function AddUser() {
    console.log("add");

    var formData = {
        username: $("#UserName").val(),
        password: $("#Password").val(),
        email: $("#Email").val(),
    };
    $(".validation-error").remove();
    $(".is-invalid").removeClass("is-invalid");

    // Regex patterns for validation
    var usernameRegex = /^[a-zA-Z0-9_-]{3,16}$/;
    var passwordRegex = /^.{5,}$/;
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (formData.username === "") {
        $("<div class='invalid-feedback'>Please enter a username.</div>").insertAfter($("#UserName"));
        $("#UserName").addClass("is-invalid");
        return;
    }
    if (!usernameRegex.test(formData.username)) {
        $("<div class='invalid-feedback'>Username must be between 3 and 16 characters and can contain letters, numbers, underscores, and hyphens.</div>").insertAfter($("#UserName"));
        $("#UserName").addClass("is-invalid");
        return;
    }

    if (formData.password === "") {
        $("<div class='invalid-feedback'>Please enter a password.</div>").insertAfter($("#Password"));
        $("#Password").addClass("is-invalid");
        return;
    }
    if (!passwordRegex.test(formData.password)) {
        $("<div class='invalid-feedback'>Password must be at least 8 characters long</div>").insertAfter($("#Password"));
        $("#Password").addClass("is-invalid");
        return;
    }

    if (formData.email === "") {
        $("<div class='invalid-feedback'>Please enter an email address.</div>").insertAfter($("#Email"));
        $("#Email").addClass("is-invalid");
        return;
    }
    if (!emailRegex.test(formData.email)) {
        $("<div class='invalid-feedback'>Please enter a valid email address.</div>").insertAfter($("#Email"));
        $("#Email").addClass("is-invalid");
        return;
    }

    $.ajax({
        url: "/Home/AddAccount",
        data: formData,
        type: "POST",
        success: function (result) {
            alert("Sign Up successful");
            window.location.href = "/Home/SignIn";
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}





