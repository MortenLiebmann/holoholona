var jsonFile = require("fs");

var object = {};

var monsters = [];
var monster = {
    Name: "Chimaera",
    Level: 12
}

jsonFile.exists("gameStructure.json", function (exists) {
    if (exists) {
        jsonFile.readFile("gameStructure.json", function readFileCallback(err, data) {
            if (err)
                console.log(err);
            else {
                object = JSON.parse(data);

                console.log(JSON.stringify(object));

                if (object.hasOwnProperty("game")) {
                    object.game.monsters.push(monster);
                    jsonFile.writeFile("gameStructure.json", JSON.stringify(object));
                }
            }
        })
    }
})