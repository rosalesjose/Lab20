function validateForm() {
    var x = document.forms["myForm"]["FirstName", "LastName"].value;
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
}