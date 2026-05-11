document.getElementById("form").addEventListener("submit", function(e) {
    e.preventDefault();

    let name = document.getElementById("name").value;
    let lname = document.getElementById("lname").value;
    let email = document.getElementById("email").value;
    let contact = document.getElementById("contact").value;
    let password = document.getElementById("password").value;
    let confirm = document.getElementById("confirm").value;

    if (name == ""||lname=="" || email == "" || password == "" || confirm == "") {
        alert("All fields are required");
        return;
    }

    if (email.indexOf("@") == -1) {
        alert("Invalid email");
        return;
    }
if (contact != "") {

    if (isNaN(contact)) {
        alert("Contact number must contain only numbers");
        return;
    }

    if (contact.length != 10) {
        alert("Contact number must be 10 digits");
        return;
    }
}


    if (password.length < 6) {
        alert("Password must be at least 6 characters");
        return;
    }

    if (password != confirm) {
        alert("Passwords do not match");
        return;
    }

    alert("Form submitted successfully");
});
