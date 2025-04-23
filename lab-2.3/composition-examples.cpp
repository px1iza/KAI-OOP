#include <iostream>
#include <vector>
#include <string>

/*──────────────────────────── 1. Car → Engine ───────────────────────────*/

class Engine {
public:
    void start() const { std::cout << "Engine started\n"; }
};

class Car {                          // «Car має Engine» (value-composition)
public:
    void drive() {
        engine_.start();
        std::cout << "Driving…\n";
    }
private:
    Engine engine_;                  // створюється / знищується разом із Car
};

/*──────────────────── 2. Window → Widget hierarchy (raw ptr) ────────────*/

class Widget {                       // абстрактна база
public:
    virtual ~Widget() = default;
    virtual void draw() const = 0;
};

class Button : public Widget {
public:
    void draw() const override { std::cout << "[Button]\n"; }
};

class Label : public Widget {
public:
    void draw() const override { std::cout << "(Label)\n"; }
};

class Window {                       // володіє колекцією вказівників
public:
    ~Window() {                      // manual memory management
        for (Widget* w : widgets_) delete w;
    }

    void add(Widget* w) { widgets_.push_back(w); }   // приймає new-створений
    void render() const {
        for (Widget* w : widgets_) w->draw();
    }
private:
    std::vector<Widget*> widgets_;
};

/*──────────────────────── 3. GameObject з компонентами ──────────────────*/

class Transform {
public:
    float x{}, y{};
};

class Physics {
public:
    float vx{}, vy{};
};

class Sprite {
public:
    std::string texture;
};

class GameObject {                   // компоненти як data-members
public:
    void update(float dt) {
        transform.x += physics.vx * dt;
        transform.y += physics.vy * dt;
    }
    Transform transform;
    Physics   physics;
    Sprite    sprite;
};

/*───────────────────── 4. Dependency injection через reference ──────────*/

class Logger {
public:
    void log(const std::string& m) const { std::cout << m << '\n'; }
};

class Service {
public:
    Service(Logger& log) : logger_(log) {}
    void run() { logger_.log("Service running"); }
private:
    Logger& logger_;                 // не володіє; просто використовує
};

/*─────────────────────────────── main() ─────────────────────────────────*/

int main() {
    // 1. Car & Engine
    Car car;
    car.drive();

    // 2. Window із Button та Label; пам’ять керуємо вручну
    Window wnd;
    wnd.add(new Button);             // передаємо право власності
    wnd.add(new Label);
    wnd.render();                    // → [Button]  (Label)

    // 3. GameObject із компонентами
    GameObject obj;
    obj.physics.vx = 1.5f;
    obj.update(2.0f);                // переміститься на 3.0 по x
    std::cout << "Obj x=" << obj.transform.x << '\n';

    // 4. Service з Logger
    Logger logger;
    Service svc(logger);
    svc.run();

    return 0;                        // Window знищує віджети у деструкторі
}


// На що звернути увагу:
// 1. Композиція “за значенням” (Car → Engine) — найпростіша: життєвий цикл повністю автоматичний.

// 2. Поліморфічна композиція (Window → Widget*) вимагає вручну delete-ти вказівники, бо ми відмовилися від smart-pointer’ів.

// 3. Компонентний патерн демонструє, як об’єкт може складатися з дрібніших об’єктів-даних.

// 4. Ін’єкція залежностей показує композицію через посилання/вказівник, коли життєвим циклом керує хтось інший.