var auto = auto || {};

auto.vehicles = {
    init: function () {
        $(".btn-add-vehicle").click(function () {
            var data = {
                'Id': 1,
                'Make.Id': 2,
                'Mpg': 51
            };

            $.ajax({
                type: 'post',
                url: 'vehicle/save',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                    $(ich.vehicle_row(response, true)).hide().appendTo("#vehicles").fadeIn(1000);
                    $('#vehicles').add()
                },
                error: function (response) {
                }
            });
        });

        $(".btn-del-vehicle").click(function () {
            console.log("del vehicle button clicked, id: ", $(this).data("id"));

        });

        $(".auto-save-vehicle").change(function () {
            var data = {
                'Id': 1,
                'Make.Id': 2,
                'Mpg': 51
            };

            $.ajax({
                type: 'post',
                url: 'vehicle/save',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                },
                error: function (response) {
                }
            });
        });

        $(".reveal-close").click(function () {
            $('#confirm-delete').foundation('reveal', 'close');
        });
    }
};

auto.init = function () {
    auto.vehicles.init();
}