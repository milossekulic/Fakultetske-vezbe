from tkinter import *
from tkinter import ttk


class Calculator:
    # Cuva trenutno unetu vrednost
    calc_value = 0.0

    # Ova vrednost ce se promeniti kada se upotrebi odredjena matematicka operacija
    div_trigger = False
    mult_trigger = False
    add_trigger = False
    sub_trigger = False

    # Uvek se aktivira kada se klikne dugme broja
    def button_press(self, value):

        # Unosi trenutnu vrednost
        entry_val = self.number_entry.get()

        # Stavlja novu vrednost sa desne strane
        # Ako se kliknu jedan za drugim 1 i 2, to ce biti 12
        # U suprotnom nov broj ide na levo
        entry_val += value

        # Cisti sve dosadasnje
        self.number_entry.delete(0, "end")

        # Ubacuje novu vrednost sa leva na desno
        self.number_entry.insert(0, entry_val)

    # Vraca brednost True ili False ako je string Float
    def isfloat(self, str_val):
        try:

            # Ako string nije Float vratice vrednost:
            # ValueError
            float(str_val)

            # Vraca vrednost(return) ako je prethodni uslov zadovoljen, u suprotno ne
            return True
        except ValueError:
            return False

    # Funkcija za definisanje pritisnutog dugmeta
    def math_button_press(self, value):

        # Uradice nesto samo ako imamo unet broj
        if self.isfloat(str(self.number_entry.get())):

            # make false to cancel out previous math button click
            self.add_trigger = False
            self.sub_trigger = False
            self.mult_trigger = False
            self.div_trigger = False

            # Uzima unetu vrednost kako bi se na nju primenila matematicka operacija
            self.calc_value = float(self.entry_value.get())

            # definisanje matematickih operacija
            if value == "/":
                print("/ Pressed")
                self.div_trigger = True
            elif value == "*":
                print("* Pressed")
                self.mult_trigger = True
            elif value == "+":
                print("+ Pressed")
                self.add_trigger = True
            else:
                print("- Pressed")
                self.sub_trigger = True

            # Ocistiti unetu vrednost
            self.number_entry.delete(0, "end")

    # Primenjuje matematicku operaciju tako sto uzima broj sa leve i broj sa desne strane
    # I vrsi matematicku operaciju izmedju njih
    def equal_button_press(self):


        if self.add_trigger or self.sub_trigger or self.mult_trigger or self.div_trigger:

            if self.add_trigger:
                solution = self.calc_value + float(self.entry_value.get())
            elif self.sub_trigger:
                solution = self.calc_value - float(self.entry_value.get())
            elif self.mult_trigger:
                solution = self.calc_value * float(self.entry_value.get())
            else:
                solution = self.calc_value / float(self.entry_value.get())

            print(self.calc_value, " ", float(self.entry_value.get()),
                  " ", solution)

            # Cisti entry box
            self.number_entry.delete(0, "end")

            self.number_entry.insert(0, solution)

    def __init__(self, root):
        # Cuva prethodno unetu vrednost
        self.entry_value = StringVar(root, value="")

        # Naslov aplikacije
        root.title("Calculator")

        # Dimenzije aplikacije
        root.geometry("600x260")

        # Blokira promenu dimenzija prozora
        root.resizable(width=False, height=False)

        # Stil dugmica i ulaza
        style = ttk.Style()
        style.configure("TButton",
                        font="Serif 15",
                        padding=10)

        style.configure("TEntry",
                        font="Serif 18",
                        padding=10)

        # kreiranje Entry box-a
        self.number_entry = ttk.Entry(root,
                                      textvariable=self.entry_value, width=50)
        self.number_entry.grid(row=0, columnspan=4)

        # ----- 1st Row -----

        self.button7 = ttk.Button(root, text="7", command=lambda: self.button_press('7')).grid(row=1, column=0)

        self.button8 = ttk.Button(root, text="8", command=lambda: self.button_press('8')).grid(row=1, column=1)

        self.button9 = ttk.Button(root, text="9", command=lambda: self.button_press('9')).grid(row=1, column=2)

        self.button_div = ttk.Button(root, text="/", command=lambda: self.math_button_press('/')).grid(row=1, column=3)

        # ----- 2nd Row -----

        self.button4 = ttk.Button(root, text="4", command=lambda: self.button_press('4')).grid(row=2, column=0)

        self.button5 = ttk.Button(root, text="5", command=lambda: self.button_press('5')).grid(row=2, column=1)

        self.button6 = ttk.Button(root, text="6", command=lambda: self.button_press('6')).grid(row=2, column=2)

        self.button_mult = ttk.Button(root, text="*", command=lambda: self.math_button_press('*')).grid(row=2, column=3)

        # ----- 3rd Row -----

        self.button1 = ttk.Button(root, text="1", command=lambda: self.button_press('1')).grid(row=3, column=0)

        self.button2 = ttk.Button(root, text="2", command=lambda: self.button_press('2')).grid(row=3, column=1)

        self.button3 = ttk.Button(root, text="3", command=lambda: self.button_press('3')).grid(row=3, column=2)

        self.button_add = ttk.Button(root, text="+", command=lambda: self.math_button_press('+')).grid(row=3, column=3)

        # ----- 4th Row -----

        self.button_clear = ttk.Button(root, text="AC", command=lambda: self.button_press('AC')).grid(row=4, column=0)

        self.button0 = ttk.Button(root, text="0", command=lambda: self.button_press('0')).grid(row=4, column=1)

        self.button_equal = ttk.Button(root, text="=", command=lambda: self.equal_button_press()).grid(row=4, column=2)

        self.button_sub = ttk.Button(root, text="-", command=lambda: self.math_button_press('-')).grid(row=4, column=3)



root = Tk()

# Napravi kalkulator
calc = Calculator(root)

# Aplikacija je pokrenuta sve dok se ne iskljuci
root.mainloop()