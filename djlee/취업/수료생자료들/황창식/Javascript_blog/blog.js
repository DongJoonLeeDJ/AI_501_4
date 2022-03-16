$("ul.tabs li:first a").addClass("active").show();
$(".tab_content:first").show();

$("ul.tabs li").click(function () {
    $("ul.tabs li a").removeClass("active");
    $(this).children('a').addClass("active");
    $(".tab_content").hide();

    var activeTab = $(this).find("a").attr("href");

    $(activeTab).fadeIn();
    return false;
});



const showoverlay = document.querySelector(".movie_blackbird");
const overlay = document.querySelector("#blackbird");
showoverlay.addEventListener('click', function () {
    overlay.classList.add("show");
});
overlay.addEventListener('click', function () {
    overlay.classList.remove("show");
});

const showoverlay2 = document.querySelector(".movie_nightingale");
const overlay2 = document.querySelector("#nightingale");
showoverlay2.addEventListener('click', function () {
    overlay2.classList.add("show");
});
overlay2.addEventListener('click', function () {
    overlay2.classList.remove("show");
});

const showoverlay3 = document.querySelector("#side_lobster");
const overlay3 = document.querySelector("#lobster");
showoverlay3.addEventListener('click', function () {
    overlay3.classList.add("show");
});
overlay3.addEventListener('click', function () {
    overlay3.classList.remove("show");
});

const showoverlay4 = document.querySelector("#side_arrival");
const overlay4 = document.querySelector("#arrival");
showoverlay4.addEventListener('click', function () {
    overlay4.classList.add("show");
});
overlay4.addEventListener('click', function () {
    overlay4.classList.remove("show");
});

const showoverlay5 = document.querySelector("#side_whiplash");
const overlay5 = document.querySelector("#whiplash");
showoverlay5.addEventListener('click', function () {
    overlay5.classList.add("show");
});
overlay5.addEventListener('click', function () {
    overlay5.classList.remove("show");
});

const showoverlay6 = document.querySelector("#side_her");
const overlay6 = document.querySelector("#her");
showoverlay6.addEventListener('click', function () {
    overlay6.classList.add("show");
});
overlay6.addEventListener('click', function () {
    overlay6.classList.remove("show");
});

const showoverlay7 = document.querySelector("#side_grand");
const overlay7 = document.querySelector("#grand");
showoverlay7.addEventListener('click', function () {
    overlay7.classList.add("show");
});
overlay7.addEventListener('click', function () {
    overlay7.classList.remove("show");
});

const showoverlay8 = document.querySelector("#side_maze");
const overlay8 = document.querySelector("#maze");
showoverlay8.addEventListener('click', function () {
    overlay8.classList.add("show");
});
overlay8.addEventListener('click', function () {
    overlay8.classList.remove("show");
});

const showoverlay9 = document.querySelector("#side_country");
const overlay9 = document.querySelector("#country");
showoverlay9.addEventListener('click', function () {
    overlay9.classList.add("show");
});
overlay9.addEventListener('click', function () {
    overlay9.classList.remove("show");
});

const showoverlay10 = document.querySelector("#side_sunshine");
const overlay10 = document.querySelector("#sunshine");
showoverlay10.addEventListener('click', function () {
    overlay10.classList.add("show");
});
overlay10.addEventListener('click', function () {
    overlay10.classList.remove("show");
});

const showoverlay11 = document.querySelector("#side_portrait");
const overlay11 = document.querySelector("#portrait");
showoverlay11.addEventListener('click', function () {
    overlay11.classList.add("show");
});
overlay11.addEventListener('click', function () {
    overlay11.classList.remove("show");
});

const showoverlay12 = document.querySelector("#side_florida");
const overlay12 = document.querySelector("#florida");
showoverlay12.addEventListener('click', function () {
    overlay12.classList.add("show");
});
overlay12.addEventListener('click', function () {
    overlay12.classList.remove("show");
});