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
                },
                error: function (response) {
                }
            });
        });

        $(".btn-del-vehicle").click(function () {
            console.log("del vehicle button clicked, id: ", $("#hid-delete-id").val());
            var data = {
                'Id': $("#hid-delete-id").val()
            };

            $.ajax({
                type: 'post',
                url: 'vehicle/delete',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                    auto.global.closeModal();
                    $("#" + data.Id).fadeOut(500);
                    $("#hid-delete-id").val("");
                },
                error: function (response) {
                }
            });

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
    }
};

auto.makes = {
    init: function () {
        $(".btn-add-make").click(function () {
            var data = {
                'Id': 1,
                'Name': "Maserati"
            };

            $.ajax({
                type: 'post',
                url: 'make/save',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                    $(ich.make_row(response, true)).hide().appendTo("#makes").fadeIn(1000);
                },
                error: function (response) {
                }
            });
        });

        $(".btn-del-make").click(function () {
            var data = {
                'Id': $("#hid-delete-id").val()
            };

            $.ajax({
                type: 'post',
                url: 'make/delete',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                    auto.global.closeModal();
                    $("#" + data.Id).fadeOut(500);
                    $("#hid-delete-id").val("");
                },
                error: function (response) {
                }
            });
        });

        $(".auto-save-make").change(function () {
            var data = {
                'Id': 1,
                'Name': "Maserati"
            };

            $.ajax({
                type: 'post',
                url: 'make/save',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                },
                error: function (response) {
                }
            });
        });
    }
};

auto.login = {
    loginUser: function () {
        var data = {
            'username': $("#username").val(),
            'password': $("#password").val()
        };

        // TODO: please, please, please use https for this.
        $.ajax({
            type: 'post',
            url: 'login/index',
            data: data,
            datatype: 'json',
            traditional: true,
            success: function (response) {
                window.location.href = response.url;
            },
            error: function (response) {
            }
        });
    },

    init: function () {
        $(".btn-login").click(function () {
            auto.login.loginUser();
        });

        $(".input-enter").keyup(function (event) {
            if (event.keyCode == 13) {
                auto.login.loginUser();
            }
        });
    },
};

auto.global = {
    closeModal: function(){
        $('#confirm-delete').foundation('reveal', 'close');
    },

    openModal: function () {
        $('#confirm-delete').foundation('reveal', 'open');
    },

    init: function () {
        $(".reveal-close").click(function () {
            auto.global.closeModal();
        });

        $(".btn-del-trigger").click(function () {
            auto.global.openModal();
            $("#hid-delete-id").val($(this).data("id"));
        });
    }
};

auto.init = function () {
    auto.vehicles.init();
    auto.makes.init();
    auto.login.init();
    auto.global.init();
};