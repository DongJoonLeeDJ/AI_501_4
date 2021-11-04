

class TV:
    # 생성자.... constructor
    def __init__(self, brand, year, inch):
        print("brand",brand)
        print("year", year)
        print("inch", inch)
        self.brand = brand
        self.year = year
        self.inch = inch

    def show(self):
        print(self.brand,"에서 만든 ",\
              self.year,"년형 ",\
              self.inch,"인치 TV")
