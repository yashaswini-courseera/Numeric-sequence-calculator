$(function () {
    var form = $("#sequenceForm");
    $("#sequenceForm").validate({
        
        rules: {
            txtNumber: {
                required: true,
                digits: true
               
            }
        }
    });
    $("#txtNumber").keyup(function () {
        if (form.valid())
            $("#SequenceTypeDrpDwn").removeAttr('disabled');
        else
            $("#SequenceTypeDrpDwn").attr('disabled', 'disabled');
    });
       
    $("#SequenceTypeDrpDwn").change(function () {
        $.ajax({
            url: "/Home/SequenceType" + "?id=" + $(this).val() + "&txtNumber=" + $("#txtNumber").val(),
            type: "GET",
            success: function (response) {
                $("#SequencePlaceholder").html(response);
            }
        })
    })
})