#Author - Brandon Steel

#import nltk
#nltk.download()
#nltk.download('punkt')
import tkinter as tk
from tkinter import *
from nltk import sent_tokenize
from nltk import word_tokenize
import re

#Create a list of words from the input file
file = open("data.txt", "r")
datawords = (file.read())
rows = sent_tokenize(datawords)


input = ""

#GUI Stuff
def show_entry_fields():
    outfile = open("output_file.txt", "w")
    root = Tk()
    input = e1.get()

    i = 0
    datasize = len(rows)
    returned_rows = []
    while (i < datasize - 1):
        valid = 1
        for k in word_tokenize(input.lower()):
            if not(k.lower() in rows[i].lower()):
                if (" " + k.lower() + " " in datawords.lower()):
                    valid = 0
                    print(k)

        if(valid == 1):
            returned_rows.append(rows[i])
            outfile.write(rows[i])
            outfile.write('\n')
        i = i + 1
    e1.delete(0, END)

    scrollbar = Scrollbar(root)
    scrollbar.pack(side=RIGHT, fill=Y)
    mylist = Listbox(root, yscrollcommand=scrollbar.set)
    for row_count in range(len(returned_rows)):
        T = Text(root, height=2, width=100)
        T.pack()
        T.insert(END, returned_rows[row_count])
        mylist.insert(END, T)
    mylist.pack(side=LEFT, fill=BOTH)
    root.mainloop()
    outfile.close()


master = tk.Tk()
tk.Label(master,text="Search Term").grid(row=0)
e1 = tk.Entry(master)


e1.grid(row=0, column=1)
tk.Button(master,
          text='Search', command=show_entry_fields).grid(row=3,
                                                       column=1,
                                                       sticky=tk.W,
                                                       pady=4)


tk.mainloop()





