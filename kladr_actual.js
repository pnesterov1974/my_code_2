const dataEndpoint = "http://localhost:5291/kladr_actual";

var table = new Tabulator("#kladr-table", {
    locale: true,
    langs: {
        "ru": {
            "custom": {
                "site_name": "Название сайта"
            },
            "data": {
                "loading": "Загрузка",
                "error": "Ошибка",
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
                "all": "Все",
                "counter": {
                    "showing": "Показано",
                    "of": "из",
                    "rows": "строк",
                    "pages": "страниц",
                }
            }
        }
    },
    height: "900px",
    ajaxURL: dataEndpoint,
    ajaxConfig: "GET",
    layout: "fitDataFill",
    pagination: "local",
    paginationSize: 40,
    paginationCounter: "rows",
    columns: [
        { title: "KladrCode", field: "KladrCode", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
        { title: "KladrSubCode", field: "KladrSubCode", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
        { title: "AreaCode", field: "AreaCode", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "DistrictCode", field: "DistrictCode", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "CityCode", field: "CityCode", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "TownCode", field: "TownCode", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "KladrLevel", field: "KladrLevel", hozAlign: "center", headerHozAlign: "center", sorter: "number" },
        { title: "ActualityStatus", field: "ActualityStatus", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "KladrName", field: "KladrName", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "KladrSocr", field: "KladrSocr", hozAlign: "socr", headerHozAlign: "center", sorter: "string" },
        { title: "KladrSocrName", field: "KladrSocrName", hozAlign: "left", headerHozAlign: "center", sorter: "string" },
        { title: "KladrIndex", field: "KladrIndex", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
        { title: "KladrGninmb", field: "KladrGninmb", hozAlign: "right", headerHozAlign: "center", sorter: "string" },
        { title: "KladrUno", field: "KladrUno", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "KladrOkatd", field: "KladrOcatd", hozAlign: "center", headerHozAlign: "center", sorter: "string" },
        { title: "KladrStatus", field: "KladrStatus", hozAlign: "center", headerHozAlign: "center", sorter: "number" }
    ],
});

table.on("tableBuild", () => {
    table.setPage(1);
});

