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
import smtplib
from requests import get, request
import sys
import requests
from bs4 import BeautifulSoup
from playsound import playsound
from pywikihow import search_wikihow
from geopy.distance import great_circle # pip install geopy
from geopy.geocoders import Nominatim # pip install geopy
import webbrowser # pip install webbrowser
import geocoder # pip install geocoder


engine = pyttsx3.init('sapi5')
voices = engine.getProperty('voices')
# print(voices[1].id)
engine.setProperty('voice', voices[1].id)
engine.setProperty('rate',175)


def speak(audio):
    engine.say(audio)
    engine.runAndWait()


def takeCommand():
    
    r = sr.Recognizer()
    with sr.Microphone() as source:
        print("Listening...")
        r.pause_threshold = 1                                           
        audio = r.listen(source,0,4)                                                                    

    try:                                                                    
        print("Recognizing...")    
        query = r.recognize_google(audio, language='en-in')
        print(f"User said: {query}\n")

    except Exception as e:
        # print(e)    
        print("Say that again please...")

        return "None"
    return query


def My_Location():

    speak("connecting to the cloud...")
    ip_add = requests.get('https://api.ipify.org').text

    url = 'https://get.geojs.io/v1/ip/geo/' +ip_add + '.json'

    geo_q = requests.get(url)

    geo_d = geo_q.json()

    state = geo_d['city']

    country = geo_d['country']

    print(f'{state , country}')

    speak(f"Your current location is  {state , country}")

    
def GoogleMaps(Place):

    Url_Place = "https://www.google.com/maps/place/" + str(Place)

    geolocator = Nominatim(user_agent="myGeocoder")

    location = geolocator.geocode(Place , addressdetails= True)

    target_latlon = location.latitude , location.longitude

    webbrowser.open(url=Url_Place)

    location = location.raw['address']

    target = {'city' : location.get('city',''),
                'state' : location.get('state',''),
                'country' : location.get('country','')}

    current_loca = geocoder.ip('me')

    current_latlon = current_loca.latlng

    distance = str(great_circle(current_latlon,target_latlon))
    distance = str(distance.split(' ',1)[0])
    distance = round(float(distance),2)

    speak(target)
    speak(f'{Place} is {distance} kilometres away from you')


def Dateconverter(Query):

    Date = Query.replace("and","-")
    Date = Date.replace("and","-")
    Date = Date.replace("and","-")
    Date = Date.replace("and","-")
    Date = Date.replace(" ","")

    return str(Date)
    
def Temp():
        search = "temperature in my current location"
        url = f"https://www.google.com/search?q={search}"
        r = requests.get(url)
        data = BeautifulSoup(r.text,"html.parser")
        temperature = data.find("div",class_ = "BNeawe").text
        speak(f"The Temperature Outside Is {temperature} ")

        speak("Do I Have To Tell You Another Place Temperature ?")
        next = takeCommand()

        if 'yes' in next:
            speak("Tell Me The Name Of tHE Place ")
            name = takeCommand()
            search = f"temperature in {name}"
            url = f"https://www.google.com/search?q={search}"
            r = requests.get(url)
            data = BeautifulSoup(r.text,"html.parser")
            temperature = data.find("div",class_ = "BNeawe").text
            speak(f"The Temperature in {name} is {temperature} celcius")

        else:
            speak("no problem sir")


from keyboard import press_and_release
from keyboard import press
import webbrowser as web

def WindowsAuto(command):

    query = str(command)

    if 'home screen' in query:

        press_and_release('windows + m')

    elif 'minimize' in query:

        press_and_release('windows + m')

    elif 'show start' in query:

        press('windows')

    elif 'open setting' in query:

        press_and_release('windows + i')

    elif 'open search' in query:

        press_and_release('windows + s')

    elif 'screen shot' in query:

        press_and_release('windows + SHIFT + s')

    elif 'restore windows' in  query:

        press_and_release('Windows + Shift + M')


def YouTubeAuto(command):

    query = str(command)

    if 'pause' in query:

        press('space bar')

    elif 'resume' in query:

        press('space bar')

    elif 'full screen' in query:

        press('f')

    elif 'film screen' in query:

        press('t')

    elif 'skip' in query:

        press('l')

    elif 'back' in query:

        press('j')

    elif 'increase' in query:

        press_and_release('SHIFT + .')

    elif 'decrease' in query:

        press_and_release('SHIFT + ,')

    elif 'previous' in query:

        press_and_release('SHIFT + p')

    elif 'next' in query:

        press_and_release('SHIFT + n')
    
    elif 'mute' in query:

        press('m')

    elif 'unmute' in query:

        press('m')