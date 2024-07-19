const dataEndpoint = "http://localhost:5291/socrbase";

var table = new Tabulator("#socrbase-table", {
    locale:true,
    langs: {
        "ru" : {
            "custom": {
                "site_name": "Название сайта"
            },
            "data":{
                "loading":"Загрузка",
                "error":"Ошибка",
            },
            "pagination": {
                "first": "Первая",
                "first_title": "Первая страница",
                "last": "Последняя",
                "last_title": "Последняя страница",
                "prev": "Предыдущая",
                "prev_title": "предыдущая страница",
                "next": "Следующая",
                "next_title": "Следующая страница",
                "all":"Все",
			    "counter":{
				    "showing": "Показано",
				    "of": "из",
				    "rows": "строк",
				    "pages": "страниц",
			    }
            }
        }
    },
    height: "850px",
    ajaxURL: dataEndpoint,
    ajaxConfig:"GET",
    layout: "fitDataFill",
    pagination: "local",
    paginationSize: 40,
    paginationCounter: "rows",
    columns: [
        { title: "level", field: "LEVEL", hozAlign: "center", headerHozAlign: "center", sorter: "number" },
        { title: "scname", field: "SCNAME", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "socrname", field: "SOCRNAME", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "kodTsT", field: "KOD_T_ST", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
    ],
    initialSort: [
        { column: "SCNAME", dir: "asc" },
        { column: "LEVEL", dir: "asc" },
    ]
});

table.on("tableBuild", () => {
    table.setPage(1);
});
