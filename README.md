## Run development build

`docker-compose -f docker-compose.dev.yml up --build`


## Run production build

`cp .env.example .env`

`docker-compose up -d -build`


## API

### Создать окружность

```
POST /shapes/circles
{
  "centerX": 0,
  "centerY": 0,
  "diameter": 10
}
```

### Создать прямоугольник

```
POST /shapes/rectangles
{
  "topLeftX": 0,
  "topLeftY": 10,
  "bottomRightX": 5,
  "bottomRightY": 0
}
```

### Создать треугольник

```
POST /shapes/triangles
{
  "x1": 0, "y1": 0,
  "x2": 4, "y2": 0,
  "x3": 0, "y3": 3
}
```

Все три ручки возвращают `201 Created` с телом фигуры (поле `type` указывает конкретный тип) и заголовком `Location`.

### Получить фигуру по id

```
GET /shapes/{id}
```

Возвращает `200 OK` с фигурой или `404 Not Found`.

### Сумма площадей всех фигур

```
GET /shapes/area
```

Возвращает `200 OK` с числом — суммой площадей всех сохранённых фигур.

## Архитектура

- Хранение - TPT (Table Per Type): базовая таблица `Shapes` (`Id`, `Area`) + отдельные таблицы `Circles`/`Rectangles`/`Triangles` со своей геометрией, связанные по `Id`.
- `Area` считается один раз при создании фигуры и хранится в базовой таблице — подсчёт суммы площадей не требует JOIN'ов
