using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore {
    public static List<Hero> Heroes { get; } = new() {

        new Hero {
            Id = 1,
            Name = "Человек паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new(){"паутина","лазание по стенам","паучье чутьё"},
            Weapon = new(){Name = "Паутинастрел" ,IsRanged = true},
            InternalNotes = "Любимый герой редактора"
        },
        new Hero {
            Id = 2,
            Name = "Бэтмен",
            RealName = "Брюс Уэйн",
            Universe = Universe.DC,
            PowerLevel = 70,
            Powers = new(){"интеоект ","боеквые искуства","технологии"},
            Weapon = new(){Name = "Бэтфранг" ,IsRanged = true},
            InternalNotes = "Без супер сил"
        },
                new Hero {
            Id = 3,
            Name = "Железный человек",
            RealName = "Тони Старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new(){"броня","полёт","лазеры"},
            Weapon = new(){Name = "Костюм марк 50" ,IsRanged = true},
            InternalNotes = "Я - железный человек"
        },
                new Hero {
            Id = 4,
            Name = "Грут",
            RealName = "Грут",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new(){"реген","управлением деревом","суперсила"},
            Weapon = new(){Name = "Ветви" ,IsRanged = false},
            InternalNotes = "я есть грут"
        },
                new Hero {
            Id = 5,
            Name = "Тор",
            RealName = "Тор",
            Universe = Universe.Marvel,
            PowerLevel = 95,
            Powers = new(){"молния","полёт","супер сила"},
            Weapon = new(){Name = "Мьёльнир" ,IsRanged = false},
            InternalNotes = "Бог грома"
        },
                new Hero {
            Id = 6,
            Name = "Рассомаха",
            RealName = "Логан",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new(){"когти","реген"},
            Weapon = new(){Name = "Когти Адомантивные" ,IsRanged = false},
            InternalNotes = "Лучший у меня есть "
        },
                new Hero {
            Id = 7,
            Name = "Дедпул",
            RealName = "Уэйд Уилсон",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new(){"реген","болтовня","владение оружием"},
            Weapon = new(){Name = "Катаны" ,IsRanged = true},
            InternalNotes = "Разрушает чёртовы стену"
        }
    };
}