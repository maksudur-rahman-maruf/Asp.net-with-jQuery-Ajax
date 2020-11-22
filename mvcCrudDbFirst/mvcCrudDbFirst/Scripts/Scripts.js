function jQueryAjaxPost(form)
{
    $.validator.unobtrusive.parse(form);
    if ($(form).valid())
    {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            success: function (response) {
                console.log(response);
            }

        });
    }
    return false;
}