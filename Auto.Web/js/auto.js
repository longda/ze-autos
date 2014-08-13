var auto = auto || {};

auto.vehicles = {
    init: function () {
        $(".btn-add-vehicle").click(function () {
            console.log("add vehicle button clicked");
        });

        $(".btn-del-vehicle").click(function () {
            console.log("del vehicle button clicked, id: ", $(this).data("id"));
        });
    }
};

auto.init = function () {
    auto.vehicles.init();
}