
$(document).ready(function(){

    var today = new Date(new Date().getFullYear(), new Date().getMonth(), new Date().getDate());

        $('#fechainicio').datetimepicker({
            minDate: today,
            maxDate: function () {
                return $('#fechafin').val();
            }
        });
        $('#fechafin').datepicker({
            minDate: function () {
                return $('#fechainicio').val();
            }
        });


}); 
