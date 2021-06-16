// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function getSpotifyCode() {
    const url = window.location.search;
    const urlCode = new URLSearchParams(url);

    const code = urlCode.get('code');
    console.log(code);
}

