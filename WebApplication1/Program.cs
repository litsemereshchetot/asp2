
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;

List<Recipe> recipes = new List<Recipe>
{
    new() {
        Id = "1",
        Stars = "2 звезды",
        Name = "Салат с креветками и кунжутом",
        Description = "Салат с креветками и кунжутом прост и лаконичен, поскольку эти морепродукты сами по себе не нуждаются в лишнем сопровождении. Майонез в салате можно заменить на натуральный йогурт или оливковое масло, смешанное с лимонным соком. А дополнить блюдо — крупно нарезанным авокадо и тертым пармезаном. Сами креветки можно приготовить тремя путями: отварить, запечь или поджарить. Главное, не делать это долгое время. При каждой из этих обработок вкус креветок будет меняться по-разному, но менее привлекательным от этого не станет.",
        Time = "20 минут",
        Portion = 2,
        Type = "Второе",
        imageUrl = "images/krevetki/krevetki.jpg",
        GalaryPhotos = new List<string> {
            "images/krevetki/1.jpg",
            "images/krevetki/2.jpg",
            "images/krevetki/3.jpg" },
        EnergyValue = new Energy
        {
            Calories = "551",
            Squirrels = "35",
            Fats = "34",
            Carbohydrates = "15"
        },
        Ingredients = new List<Ingredient>
        {
            new()
            {
                Name = "Помидоры",
                Amount = "3 штуки"
            },
            new()
            {
                Name = "Королевские креветки",
                Amount = "300 г"
            },
            new()
            {
                Name = "Зеленый салат",
                Amount = "1 пучок"
            },
            new()
            {
                Name = "Огурцы",
                Amount = "2 штуки"
            },
            new()
            {
                Name = "Соль",
                Amount = "по вкусу"
            },
            new()
            {
                Name = "Майонез",
                Amount = "по вкусу"
            },
            new()
            {
                Name = "Кунжутные семечки",
                Amount = "3 столовые ложки"
            },
            new()
            {
                Name = "Молотый черный перец",
                Amount = "по вкусу"
            },
            new()
            {
                Name = "Сушеный красный перец",
                Amount = "½ штуки"
            },
            new()
            {
                Name = "Лимон",
                Amount = "½ штуки"
            },
            new()
            {
                Name = "Оливковое масло",
                Amount = "2 столовые ложки"
            },
        },
        Steps = new List<Step>
        {
            new()
            {
                ImageUrl =  "/images/krevetki/steps/1.jpg",
                Description = "Порезать овощи крупно, салат порвать на куски."
            },
            new()
            {
                ImageUrl =  "/images/krevetki/steps/2.jpg",
                Description = "Для креветок: Довести до кипения сильно соленую воду с красным и черным перцем, оливковым маслом и половинкой лимона (сок предварительно выжать в воду)."
            },
            new()
            {
                ImageUrl =  "/images/krevetki/steps/3.jpg",
                Description = "Добавить креветки. После кипения варить 5 минут."
            },
            new()
            {
                ImageUrl =  "/images/krevetki/steps/4.jpg",
                Description = "Очистить креветки от панциря."
            },
            new()
            {
                ImageUrl =  "/images/krevetki/steps/5.jpg",
                Description = "Смешать овощи и креветки."
            },
            new()
            {
                ImageUrl =  "/images/krevetki/steps/6.jpg",
                Description = "Посыпать кунжутными семечками и заправить майонезом."
            },
        }
    },

    new() {
        Id = "2",
        Name = "Брауни",
        Stars = "2 звезды",
        Description = "Один из самых популярных десертов в мире — брауни — был придуман в 1893 году на кухне легендарного отеля Palmer House в Чикаго. Этот пирог там пекут до сих пор по оригинальному рецепту, покрывая сверху абрикосовой глазурью. В домашней версии, впрочем, у брауни получается такая изумительная сахарная корочка, что глазировать ее было бы преступлением. У традиционных шоколадных брауни ванильный аромат, хрустящая корочка и влажная серединка. В торт также добавляют грецкие орехи или фисташки, а еще клюкву.",
        Time = "40 минут",
        Portion = 6,
        Type = "Десерт",
        imageUrl = "images/brauni/brauni.jpg",
        GalaryPhotos = new List<string> {
            "/images/brauni/1.jpg",
            "/images/brauni/2.jpg",
            "/images/brauni/3.jpg" },
        EnergyValue = new Energy
        {
            Calories = "667",
            Squirrels = "10",
            Fats = "46",
            Carbohydrates = "55"
        },
        Ingredients = new List<Ingredient>
        {
            new()
            {
                Name = "Темный шоколад",
                Amount = "100 г"
            },
            new()
            {
                Name = "Сливочное масло",
                Amount = "180 г"
            },
            new()
            {
                Name = "Коричневый сахар",
                Amount = "200 г"
            },
            new()
            {
                Name = "Куриное яйцо",
                Amount = "4 штуки"
            },
            new()
            {
                Name = "Пшеничная мука",
                Amount = "100 г"
            },
            new()
            {
                Name = "Грецкий орех",
                Amount = "100 г"
            },
        },
        Steps = new List<Step>
        {
            new()
            {
                ImageUrl =  "/images/brauni/steps/1.jpg",
                Description = "Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане, не переставая все время помешивать лопаткой или деревянной ложкой. Получившийся густой шоколадный соус снять с водяной бани и оставить остывать."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/2.jpg",
                Description = "Тем временем смешать яйца со ста граммами коричневого сахара: яйца разбить в отдельную миску и взбить, постепенно добавляя сахар. Взбивать можно при помощи миксера или вручную — как больше нравится, — но не меньше двух с половиной-трех минут."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/3.jpg",
                Description = "Острым ножом на разделочной доске порубить грецкие орехи. Предварительно их можно поджарить на сухой сковороде до появления аромата, но это необязательная опция."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/4.jpg",
                Description = "В остывший растопленный со сливочным маслом шоколад аккуратно добавить оставшийся сахар, затем муку и измельченные орехи и все хорошо перемешать венчиком."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/5.jpg",
                Description = "Затем влить сахарно-яичную смесь и тщательно смешать с шоколадной массой. Цвет у теста должен получиться равномерным, без разводов."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/6.jpg",
                Description = "Разогреть духовку до 200 градусов. Дно небольшой глубокой огнеупорной формы выстелить листом бумаги для выпечки или калькой. Перелить тесто в форму. Поставить в духовку и выпекать двадцать пять — тридцать минут до появления сахарной корочки."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/7.jpg",
                Description = "Готовый пирог вытащить из духовки, дать остыть и нарезать на квадратики острым ножом или ножом для пиццы — так кусочки получатся особенно ровными."
            },
            new()
            {
                ImageUrl =  "/images/brauni/steps/8.jpg",
                Description = "Подавать брауни можно просто так, а можно посыпать сверху сахарной пудрой или разложить квадратики по тарелкам и украсить каждую порцию шариком ванильного мороженого."
            },
        }
    }
};





var builder = WebApplication.CreateBuilder(
        new WebApplicationOptions { WebRootPath = "assets"}
    );
var app = builder.Build();

app.UseDefaultFiles();

var cacheMaxAgeOneWeek = "10"; /*seconds*/
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        ctx.Context.Response.Headers.Append(
             "Cache-Control", $"public, max-age={cacheMaxAgeOneWeek}");
    }
});


app.Map("/recipe/{id}", async (context) =>
{
    await context.Response.SendFileAsync("assets/html/recipe-full.html");
});

app.Map("/add", async (context) =>
{
    await context.Response.SendFileAsync("assets/html/add.html");
});
 
app.Map("/all-recipe", async(context) =>
{
    await context.Response.SendFileAsync("assets/html/all-recipe.html");
});


app.Map("/api/recipe/{id}", async (context) => {
    await context.Response.WriteAsJsonAsync(context.Request.Query);
});


app.Map("/api/add", async (context) => {
    var request = context.Request;
    var recipe = await request.ReadFromJsonAsync<NotFullRecipe>();
    var kk = AddRecipe(recipe);
    
    await context.Response.WriteAsync(Convert.ToString(kk));
});


app.MapGet("/api/recipe/{id}", (string id) =>
{
    Recipe? recipe = recipes.FirstOrDefault(u => u.Id == id);
    if (recipe == null) return Results.NotFound(new { message = "Рецепт не найден" });

    return Results.Json(recipe);
});


app.Map("/api/recipe/get-all", getAllRecipes);

app.Run();

async Task getAllRecipes(HttpContext context)
{
    await context.Response.WriteAsJsonAsync(recipes);
}



bool AddRecipe(NotFullRecipe recipe)
{
        var ret = true;
    try
    {
        DB db = new DB();
        var con = db.getConnection();
        MySqlCommand command = new MySqlCommand("INSERT INTO `recipedescription` (`id`, `name`, `description`, `time`, `portion`, `type`, `imageUrl`, `stars`, `calories`, `squirrels`, `fats`, `carbohydrates`) " +
            "VALUES (NULL, @name, @desc, @time, @portion, @type, @imageUrl, @stars, @c, @s, @f, @car)", con);
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = recipe.Name;
        command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = recipe.Description;
        command.Parameters.Add("@time", MySqlDbType.VarChar).Value = recipe.Time;
        command.Parameters.Add("@portion", MySqlDbType.Int64).Value = recipe.Portion;
        command.Parameters.Add("@type", MySqlDbType.VarChar).Value = "";
        command.Parameters.Add("@imageUrl", MySqlDbType.VarChar).Value = recipe.imageUrl;
        command.Parameters.Add("@stars", MySqlDbType.VarChar).Value = recipe.Stars;
        command.Parameters.Add("@c", MySqlDbType.Int64).Value = recipe.EnergyValue.Calories;
        command.Parameters.Add("@s", MySqlDbType.Int64).Value = recipe.EnergyValue.Squirrels;
        command.Parameters.Add("@f", MySqlDbType.Int64).Value = recipe.EnergyValue.Fats;
        command.Parameters.Add("@car", MySqlDbType.Int64).Value = recipe.EnergyValue.Carbohydrates;

        db.openConnection();
        if (command.ExecuteNonQuery() != 1)
        {
            ret = false;
        }
    

    db.closeConnection();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    return ret;
}


public class DB
{
    MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=recipe");

    public void openConnection()
    {
        if (con.State == System.Data.ConnectionState.Closed)
        {
            con.Open();
        }
    }
    public void closeConnection()
    {
        if (con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
        }
    }

    public MySqlConnection getConnection()
    {
        return con;
    }
}


public class NotFullRecipe
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Time { get; set; } = "";
    public int Portion { get; set; }
    public string Stars { get; set; } = "";
    public string Type { get; set; } = "";
    public string imageUrl { get; set; } = "";
    public Energy2 EnergyValue { get; set; }
}

public class Recipe
{
    public string Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Time { get; set; } = "";  
    public int Portion { get; set; }
    public string Stars { get; set; } = "";
    public string Type { get; set; } = "";
    public string imageUrl { get; set; } = "";
    public List<string> GalaryPhotos { get; set;} = new List<string>();
    public Energy EnergyValue { get; set; } 
    public List<Ingredient> Ingredients { get; set; }
    public List<Step> Steps { get; set; }

}

public class Energy2
{
    public int Calories { get; set; } = 0;
    public int Squirrels { get; set; } = 0;
    public int Fats { get; set; } = 0;
    public int Carbohydrates { get; set; } = 0;

}
public class Energy
{
    public string Calories { get; set; } = "";
    public string Squirrels { get; set; } = "";
    public string Fats { get; set; } = "";
    public string Carbohydrates { get; set; } = "";

}

public class Ingredient
{
    public string Name { get; set; } = "";
    public string Amount { get; set; } = "";
}

public class Step
{
    public string ImageUrl { get; set; } = "";
    public string Description { get; set; } = "";
}