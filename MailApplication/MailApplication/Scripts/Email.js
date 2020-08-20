function SendMail() {
    if ($('#To').val() == "" || $('#To').val() != "") {

        var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
        var emailLegalReg = /^([\w-\.]+@(?!gmail.com)(?!yahoo.com)(?!hotmail.com)(?!aol.com)([\w-]+\.)+[\w-]{2,4})?$/;

        var emailaddressVal = $("#To").val();
        if (emailaddressVal == '') {
            alert("Please enter your email address.");
            return false;
        } else if (!emailReg.test(emailaddressVal)) {
            alert("Enter a valid email address.");
            return false;
        } else if (emailLegalReg.test(emailaddressVal)) {
            alert("No eamil apart from gmail, hotmail or yahoo is allowed.");
            return false;
        }
    }
    if ($('#Subject').val() == "") {
        alert("Please enter the subject!");
        return false;
    }
    else if ($('#BodyText').val() == "") {
        alert("Please enter the mail body!");
        return false;
    }
    return true;
}