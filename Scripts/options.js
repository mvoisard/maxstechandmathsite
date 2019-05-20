function saveOptions(e) {
    var color = document.getElementById('color').value;
    var likesColor = document.getElementById('like').checked;
    browser.storage.sync.set({
        favoriteColor: color,
        likesColor: likesColor
    }, function () {
        // Update status to let user know options were saved.
        var status = document.getElementById('status');
        status.textContent = 'Options saved.';
        setTimeout(function () {
            status.textContent = '';
        }, 750);
    browser.storage.sync.set({
        colour: document.querySelector("#colour").value
    });
    e.preventDefault();
},

function restoreOptions() {
    browser.storage.sync.get({
        favoriteColor: 'red',
        likesColor: true
    }, function (items) {
        document.getElementById('color').value = items.favoriteColor;
        document.getElementById('like').checked = items.likesColor;
    });
    var storageItem = browser.storage.managed.get('colour');
    storageItem.then((res) => {
        document.querySelector("#managed-colour").innerText = res.colour;
    });

    var gettingItem = browser.storage.sync.get('colour');
    gettingItem.then((res) => {
        document.querySelector("#colour").value = res.colour || 'Firefox red';
    });
},

document.addEventListener('DOMContentLoaded', restoreOptions);
document.querySelector("form").addEventListener("submit", saveOptions);
document.getElementById('save').addEventListener('click',
    save_options);