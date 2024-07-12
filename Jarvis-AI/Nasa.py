import requests
import os
from PIL import Image
import pyttsx3
import matplotlib.pyplot as plt # pip install matplotlib


Api_key = "7ZXkdMVvFEKJOSYUBke8DLZhKA6Hs32BQFiCwGl7"


engine = pyttsx3.init('sapi5')
voices = engine.getProperty('voices')
# print(voices[1].id)
engine.setProperty('voice', voices[1].id)
engine.setProperty('rate',172)


def speak(audio):
    engine.say(audio)
    engine.runAndWait()

def NasaNews(Date):

    speak('connecting to cortana cloud....')

    Url = "https://api.nasa.gov/planetary/apod?api_key=" + str(Api_key)

    Params = {'date':str(Date)}
    
    r = requests.get(Url,params = Params)

    Data = r.json()

    Info = Data['explanation']

    Title = Data['title']

    Image_Url = Data['url']

    Image_r = requests.get(Image_Url)

    FileName = str(Date) + '.jpg'

    with open(FileName,'wb') as f:

        f.write(Image_r.content)

    Path_1 = "C:\\Users\\Usuario\\Desktop\\jarvisGUI\\"+ str(FileName)

    Path_2 = "C:\\Users\\Usuario\\Desktop\\jarvisGUI\\Nasa" + str(FileName)

    os.rename(Path_1, Path_2)

    img = Image.open(Path_2)

    img.show()

    speak(f"Title : {Title}" )
    speak(f'According to Space station : {Info}')

