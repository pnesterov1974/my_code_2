const dataEndpoint = "http://localhost:5291/street";

var table = new Tabulator("#kladr-table", {
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
    ajaxConfig: "GET",
    layout: "fitDataFill",
    pagination: "local",
    paginationSize: 40,
    paginationCounter: "rows",
    columns: [
        { title: "code", field: "CODE", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
        { title: "name", field: "NAME", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "socr", field: "SOCR", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "index", field: "INDEX", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "gninmb", field: "GNINMB", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
        { title: "uno", field: "UNO", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "ocatd", field: "OCATD", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
    ],
    initialSort: [
         { column: "CODE", dir: "asc" },
         { column: "STATUS", dir: "asc" },
    ]
});

table.on("tableBuild", () => {
    table.setPage(1);
});

