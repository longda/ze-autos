var auto = auto || {};

auto.vehicles = {
    init: function () {
        $(".btn-add-vehicle").on("click", function () {
            var data = {
                'Id': 0,
                'Make.Id': $("#add-vehicle .make-drop-down").val(),
                'Mpg': 0
            };

            $.ajax({
                type: 'post',
                url: 'vehicle/save',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                    $('#add-vehicle').foundation('reveal', 'close');
                    $(ich.vehicle_row(response, true)).hide().appendTo("#vehicles").fadeIn(1000);
                },
                error: function (response) {
                }
            });
        });

        $(".btn-del-vehicle").on("click", function () {
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

        $("#vehicles").on("change keyup paste input", ".auto-save-vehicle", function () {
            var data = {
                'Id': $(this).data("id"),
                'Mpg': $(this).val()
            };

            console.log("data: " + data);

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
        $(".btn-add-make").on("click", function () {
            var data = {
                'Id': 0,
                'Name': "Car name"
            };

            $.ajax({
                type: 'post',
                url: 'make/save',
                data: data,
                datatype: 'json',
                traditional: true,
                success: function (response) {
                    $(ich.make_row(response, true)).hide().appendTo("#makes").fadeIn(1000);
                    $("#" + response.Id + " .make-name").focus();
                },
                error: function (response) {
                }
            });
        });

        $(".btn-del-make").on("click", function () {
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

        $("#makes").on("change keyup paste input", ".auto-save-make", function () {
            var data = {
                'Id': $(this).data("id"),
                'Name': $(this).val()
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
        $(".btn-login").on("click", function () {
            auto.login.loginUser();
        });

        $(".input-enter").keyup(function (event) {
            if (event.keyCode == 13) {
                auto.login.loginUser();
            }
        });

        $("#username").focus();
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
        $(".grid").on("click", ".reveal-close", function () {
            auto.global.closeModal();
        });

        $(".grid").on("click", ".btn-del-trigger", function () {
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