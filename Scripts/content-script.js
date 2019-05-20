var browser = require("webextension-polyfill");

browser.storage.local.set({
    [window.location.hostname]: document.title,
}).then(() => {
    browser.runtime.sendMessage(`Saved document title for ${window.location.hostname}`);
});

window.addEventListener("click", notifyExtension);
function notifyExtension(e) {
    if (e.target.tagName != "A") {
        return;
    }
    browser.runtime.sendMessage({ "url": e.target.href });
}