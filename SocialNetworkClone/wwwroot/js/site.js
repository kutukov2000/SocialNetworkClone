// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Отримайте модальне вікно
var modals = document.querySelectorAll(".modal");
var openModals = document.querySelectorAll(".openModal");

for (var i = 0; i < openModals.length; i++) {
    openModals[i].onclick = function () {
        var dataIndex = this.getAttribute("data-index");

        if (modals[dataIndex]) {
            modals[dataIndex].style.display = "flex";
        } else {
            console.error("Modal not found");
        }
    };
}

// Отримайте елементи, які закривають модальне вікно
var spans = document.querySelectorAll(".close");

// Функція для закриття модального вікна
for (var i = 0; i < spans.length; i++) {
    spans[i].onclick = function () {
        var dataIndex = this.getAttribute("data-index");
        modals[dataIndex].style.display = "none";
    };
}

// Закрийте модальне вікно, якщо користувач клікає поза ним
window.onclick = function (event) {
    for (var i = 0; i < modals.length; i++) {
        if (event.target == modals[i]) {
            modals[i].style.display = "none";
        }
    }
};

