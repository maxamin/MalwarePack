from sqlite3 import Date
from typing_extensions import Self
from numpy import place
import speedtest
from distutils.command.upload import upload
import imp
from jmespath import search
import pyttsx3 #pip install pyttsx3
import speech_recognition as sr #pip install speechRecognition
import datetime
import wikipedia #pip install wikipedia
import webbrowser
import pywhatkit
import pyjokes
import os
import wolframalpha
from requests import get, request
import sys
import requests
from bs4 import BeautifulSoup
from playsound import playsound
from pywikihow import search_wikihow
from keyboard import press_and_release
from keyboard import press
from PyQt5 import QtWidgets, QtCore, QtGui
from PyQt5.QtCore import QTimer, QTime, QDate, Qt
from PyQt5.QtGui import QMovie
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
from PyQt5.uic import loadUiType
from jarvisUi import Ui_jarvisUi
import psutil


engine = pyttsx3.init('sapi5')
voices = engine.getProperty('voices')
# print(voices[1].id)
engine.setProperty('voice', voices[1].id)
engine.setProperty('rate',175)


def speak(audio):
    engine.say(audio)
    engine.runAndWait()



def startup():
    speak("Initializing the cloud...")
    speak("Starting all systems applications")
    speak("Installing and checking all drivers")
    speak("Caliberating and examining all the core processors")
    speak("Checking the internet connection")
    speak("Wait a moment sir")
    speak('Updating the cloud configuration')
    speak("All drivers are up and running")
    speak("All systems have been activated")

def computational_intelligence(question):
    try:
        client = wolframalpha.Client('4H2PW2-3JYYGVHJQ6')
        answer = client.query(question)
        answer = next(answer.results).text
        print(answer)
        return answer
    except:
        speak("Sorry sir I couldn't fetch your question's answer. Please try again ")
        return None

def wishMe():
    hour = int(datetime.datetime.now().hour)
    if hour>=0 and hour<12:
        
        speak("GoodMorning sir!")

    elif hour>=12 and hour<18:
        speak("GoodAfternoon sir!")
          

    else:
        speak("GoodEvening sir!")  
        

    speak("Please tell me how may I help you")       

class MainThread(QThread):
    def __init__(self):
        super(MainThread, self).__init__()

    def run(self):
        self.TaskExecution()


    def takeCommand(self):
        #It takes microphone input from the user and returns string output

        r = sr.Recognizer()
        with sr.Microphone() as source:
            print("Listening...")
            r.pause_threshold = 1                                           
            audio = r.listen(source,0,4)                                                                    

        try:                                                                    
            print("Recognizing...")    
            self.query = r.recognize_google(audio, language='en-us')
            print(f"User said: {self.query}\n")

        except Exception as e:
            # print(e)    
            print("Say that again please...")

            return "None"
        return self.query


    def TaskExecution(self):
        startup()
        wishMe()
        while True:
        # if 1:
            self.query = self.takeCommand().lower()

            # Logic for executing tasks based on self.query
            
            
        

            if 'tell me about' in self.query:
                speak('Searching Wikipedia...please wait')
                
                self.query = self.query.replace("wikipedia", "")
                results =  wikipedia.summary(self.query, sentences = 2)
                speak("Internet says...")
                print(results)
                speak(results) 

            elif 'hay'in self.query:
                playsound('effect.mp3')
                Path = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Rainmeter.lnk"
                os.startfile(Path)
                speak('i am on.. ')

            elif "calculate" in self.query:
                question = self.query
                answer = computational_intelligence(question)
                speak(answer)
            
            elif "what is" in self.query or "who is" in self.query:
                question = self.query
                answer = computational_intelligence(question)
                speak(answer)

        
            elif 'open youtube' in self.query:
                webbrowser.open("youtube.com")

            elif 'open google' in self.query:
                webbrowser.open("google.com")

            elif 'open stackoverflow' in self.query:
                webbrowser.open("stackoverflow.com")   

            if "hello" in self.query:
                speak('Hello sir , Good to see you')
                speak('How may i help You?')

            elif 'current temperature' in self.query:
                search = "temperature in my current location"
                url = f"https://www.google.com/search?q={search}"
                r = requests.get(url)
                data = BeautifulSoup(r.text, "html.parser")
                temp = data.find("div",class_="BNeawe").text
                speak(f'the current temperature in your current location is {temp}')

                
                
            elif 'nice' in self.query:
                speak(" 24/7 in your service sir ! you can call me anytime")
            
                sys.exit()

            elif 'shutup' in self.query:
                sys.exit()

            elif 'the time' in self.query:
                strTime = datetime.datetime.now().strftime("%H:%M:%S")    
                speak(f"Sir, the time is {strTime}")


            elif 'play' in self.query:
                speak('Surfing the browser.... Hold on sir') 
                
                self.query = self.query.replace('jarvis'," ")  
                self.query = self.query.replace('play'," ")
                web = 'https://www.youtube.com/results?search_self.query=' + self.query
                pywhatkit.playonyt(self.query)
                speak(' Enjoy the music ')

            elif 'facebook' in self.query:
                playsound('effect.mp3')
                speak('alright...')
                
                webbrowser.open("https://www.facebook.com")
                speak('Shall I readout the messages ?')

            elif "game" in self.query:
                from game import game_play
                game_play()

            elif 'joke' in self.query:
                speak(pyjokes.get_joke())
                

            elif "ip address" in self.query:
                ip = get("https://api.ipify.org").text
                
                speak(f'Your current ip address is {ip}') 
                

            elif 'search' in self.query:
                import wikipedia as googleScrap
                self.query = self.query.replace('jarvis', '   ')
                self.query = self.query.replace('google search', '    ')
                self.query = self.query.replace('google','    ')
            
                speak('Here are some results...')

                try:
                    pywhatkit.search(self.query)
                    result = googleScrap.summary(self.query,3)
                    speak(result)

                except:
                    speak(' Data not cached..')
                    
            #elif 'my location' in self.query:
                #from Features import My_Location
                #My_Location()              
        
                

            elif "internet speed" in self.query:
                    wifi  = speedtest.Speedtest()
                    upload_net = wifi.upload()/1048576        
                    download_net = wifi.download()/1048576
                    print("Wifi Upload Speed is", upload_net)
                    print("Wifi download speed is ",download_net)
                    speak(f"Wifi download speed is {download_net} MB per second")
                    speak(f"Wifi Upload speed is {upload_net} MB per second")
                
            elif "screenshot" in self.query:
                    import pyautogui #pip install pyautogui
                    im = pyautogui.screenshot()
                    im.save("ss.jpg")

            elif 'my music' in self.query:
                    music_dir = "C:\\Users\\Usuario\\Music"
                    songs = os.listdir(music_dir)
                    
                    os.startfile(os.path.join(music_dir, songs[3]))

            elif 'how to' in self.query:
                speak('Searching for best results.....')
                op = self.query.replace("jarvis","   ")
                max_result = 1
                how_to_func = search_wikihow(op,max_result)
                assert len (how_to_func) == 1
                how_to_func[0].print()
                speak(how_to_func[0].summary)


            elif 'where is' in self.query:
                from Features import GoogleMaps
                Place = self.query.replace('where is' ,"  ")
                Place = Place.replace("cortana", "  ")
                GoogleMaps(Place)

            elif 'space news' in self.query:
                speak('Say the date separated by And. For example 2021 and 12 and 09')

                Date = self.takeCommand()
                from Features import Dateconverter
                value = Dateconverter(Date)
                from Nasa import NasaNews
                NasaNews(value)    

        
startExecution = MainThread()

class Main(QMainWindow):
    def __init__(self):
        super().__init__()
        self.ui = Ui_jarvisUi()
        self.ui.setupUi(self)
        self.ui.pushButton.clicked.connect(self.startTask)
        self.ui.pushButton_2.clicked.connect(self.close)

    def __del__(self):
        sys.stdout = sys.__stdout__

    def startTask(self):
        self.ui.movie = QtGui.QMovie(".\\Material/new.gif")
        self.ui.label_2.setMovie(self.ui.movie)
        self.ui.movie.start()
        self.ui.movie = QtGui.QMovie(".\\Material/path.gif")
        self.ui.label_3.setMovie(self.ui.movie)
        self.ui.movie.start()
        self.ui.movie = QtGui.QMovie(".\\Material/logo.gif")
        self.ui.label_5.setMovie(self.ui.movie)
        self.ui.movie.start()
        timer = QTimer(self)
        timer.timeout.connect(self.showTime)
        timer.start(1000)
        startExecution.start()

    def showTime(self):
        current_time = QTime.currentTime()
        current_date = QDate.currentDate()
        label_time = current_time.toString('hh:mm:ss')
        label_date = current_date.toString(Qt.ISODate)
        self.ui.textBrowser.setText(label_date)
        self.ui.textBrowser_2.setText(label_time)

app = QApplication(sys.argv)
jarvis = Main()
jarvis.show()
exit(app.exec_())
