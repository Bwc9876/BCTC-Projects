# show the weather forecast for the next 5 days
#

# import the requests library
import requests

# import the datetime library
import datetime

# import the json library
import json

# import the time library
import time

# import the sys library
import sys

# import the os library
import os

# import the argparse library
import argparse

def main():
    # get the command line arguments
    parser = argparse.ArgumentParser()
    parser.add_argument("-c", "--city", help="city name")
    parser.add_argument("-s", "--state", help="state name")
    parser.add_argument("-d", "--date", help="date")
    args = parser.parse_args()

    # get the city name
    city = args.city
    # get the state name
    state = args.state
    # get the date
    date = args.date

    # get the current date
    today = datetime.datetime.now()
    # get the current year
    year = 2022
    # get the current month
    month = 3
    # get the current day
    day = today.day

    # get the current time
    current_time = time.time()

    # get the current date and time
    current_date_time = datetime.datetime.fromtimestamp(current_time)

    # request the weather forecast
    r = requests.get('http://api.wunderground.com/api/f8f8f8f8f8f8f8f8/forecast10day/q/' + state + '/' + city + '.json')

    # show the status code
    print('Status Code: ' + str(r.status_code))

    # get the json data
    json_data = r.json()

    # get the forecast
    forecast = json_data['forecast']['simpleforecast']['forecastday']
    # get the forecast for the next 5 days
    forecast_next_5_days = forecast[0:5]
    # get the forecast for the next 5 days
    forecast_next_5_days_2 = forecast[0:5]
    # print the forecast for the next 5 days
    print('Forecast for the next 5 days:')


if __name__ == '__main__':
    main()