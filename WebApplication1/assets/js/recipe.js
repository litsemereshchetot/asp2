let addClickListeners = () => {
    let recipes = document.querySelectorAll(".recipe")
    recipes.forEach((recipe) => {
        let mainPhoto = recipe.querySelector(".recipe__image")
        let galaryPhotos = recipe.querySelectorAll(".recipe__galary-item")
        galaryPhotos.forEach((galaryPhoto) => {
            galaryPhoto.addEventListener("click", () => {
                [galaryPhoto.innerHTML, mainPhoto.innerHTML] = [mainPhoto.innerHTML, galaryPhoto.innerHTML]
            })
        })
    })
};