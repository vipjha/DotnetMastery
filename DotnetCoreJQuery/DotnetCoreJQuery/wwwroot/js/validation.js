function validateEmail(email){
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email)
}

function isValidEmail(emailText) {
    var pattern = new RegExp("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
    return pattern.test(emailText)
}

function fnValidateMobileNo(data) {
    var regex = new RegExp("^([+][9][1]|[9][1]|[0]){0,1}([6-9]{1})([0-9]{9})$");
    return regex.test(data);
}

function isNumberKey(evt) {
    var chrCode = (evt.which) ? evt.which : event.keyCode
    if (chrCode > 31 && (chrCode < 48 || chrCode > 57)) return false;
    return true
}