from dataclasses import dataclass
from datetime import date, datetime
import sys
from typing import Optional


@dataclass(frozen=True, slots=True)
class Sighting:
    ttss_number: int
    date_of_sighting: date
    vehicle_name: str


# Source: https://stackoverflow.com/a/69776706/13849454
def convert(n, counter = None):
    if not counter:
        counter = 0
    counter += 1
    if n > 1:
        convert(n//2, counter)
    if counter % 4 == 0:
        print(" ", end="")
    print(n % 2, end = '')


def main2():
    filename = sys.argv[1]
    ttss_numbers: list[int] = []
    with open(filename) as f:
        for line in f.readlines():
            ttss_numbers.append(int(line))
    for ttss_number in ttss_numbers:
        print(f'{ttss_number} | {hex(ttss_number)} | {bin(ttss_number)}', end="")
        # convert(-ttss_number)
        print()


def main():
    raw_filename = sys.argv[1]
    sightings: list[Sighting] = []
    current_date = datetime.now()
    with open(raw_filename) as raw_file:
        for line in raw_file.readlines():
            ttss_number, rest = line.split(' : ')
            ttss_number = int(ttss_number)
            name, *rest = rest.split(' ')
            name = name.strip()
            rest = (rest or [None])[0]
            if rest:
                date_str = rest[1:][:-2]
                current_date = datetime.strptime(date_str, '%d.%m.%Y').date()
            sightings.append(Sighting(ttss_number=ttss_number, date_of_sighting=current_date, vehicle_name=name))
    grouped: dict[str, list[tuple[int, date]]] = {}
    for sighting in sightings:
        if sighting.vehicle_name not in grouped:
            grouped[sighting.vehicle_name] = []
        grouped[sighting.vehicle_name].append((sighting.ttss_number, sighting.date_of_sighting))
    for key, group in grouped.items():
        print(key)
        previous_ttss: Optional[int] = None
        previous_date: Optional[date] = None
        for ttss_number, date_of_sighting in group:
            if previous_ttss is not None:
                day_diff = (date_of_sighting - previous_date).days
                ttss_diff = ttss_number - previous_ttss
                print(f'\t\t{day_diff} days: {ttss_diff} ; {ttss_diff / day_diff} per day')
            #else:
            previous_ttss = ttss_number
            previous_date = date_of_sighting
            print(f'\t{date_of_sighting}: {ttss_number} | {hex(ttss_number)} | {bin(ttss_number)}')
        print()


if __name__ == '__main__':
    main()