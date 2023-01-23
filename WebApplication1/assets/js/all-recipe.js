let allRecipes = getRecipes();
console.log(allRecipes);


console.log('addd', addClickListeners())
for (let i = 0; i < allRecipes.length; i++) {
    document.querySelector('.main__recipe-list').innerHTML += compileRecipe(allRecipes[i]);
}


function compileRecipe(recipe) {



    return `
        <div class="recipe">
        <div class="index">${recipe}</div>
            <div class="recipe__image">
                <img src="${recipe.imageUrl}" alt="">
            </div>
            <div class="recipe__card">
                <div class="recipe__stars-and-type">
                    <pre><span class="recipe__stars">${recipe.stars}</span>   <span class="recipe__type">${recipe.type}</span></pre>
                </div>
                <div class="recipe__name"><p>${recipe.name}</p></div>
                <div class="recipe__info">
                    <div class="recipe__ingredients">${recipe.ingredients.length + " ингридиентов"}</div>
                    <div class="recipe__portion">${recipe.portion + " порций"}</div>
                    <div class="recipe__time">${recipe.time}</div>
                </div>
                <div class="recipe__galary">
                    ${function (galary) {
            let ret = ""
            for (let i = 0; i < galary.length; i++) {
                ret = ret + `
                                <div class="recipe__galary-item">
                                    <img src="${galary[i]}" alt="">
                                </div>
                                `

            }
            return ret
        }(recipe.galaryPhotos)
        }
                </div>
            </div>
        </div>
    `
}

async function getRecipes() {
    const response = await fetch(`/api/recipe/get-all`, {
        methid: "GET",
        headers: { "Accept": "application/json" }
    });
    if (response.ok === true) {
        return await response.json();
    }
    alert("Something was wrong");
}
