function showCharacteristic(button) {
    const modal = document.getElementById("characteristic-modal");
    const name = document.getElementById("modal-characteristic-name");
    const description = document.getElementById("modal-characteristic-description");

    name.textContent = button.dataset.name;
    description.textContent = button.dataset.description || "Definición no disponible.";

    modal.classList.add("show");
}

function closeCharacteristic(event) {
    if (event && event.target !== event.currentTarget) {
        return;
    }

    document.getElementById("characteristic-modal").classList.remove("show");
}