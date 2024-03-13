import random
import time


def generate_lotery_numbers(item_count, frm, to):
    numbers = []
    while len(numbers) < item_count:
        number = random.randint(frm, to)
        if number not in numbers:
            numbers.append(number)
    return numbers


def get_matched_count(first, second):
    count = 0
    for i in range(len(first)):
        if first[i] in second:
            count += 1
    return count


if (__name__ == "__main__"):
    new_system_max_number = 90
    new_system_slot_count = 6
    new_system_matched_count = 0
    new_system_try_count = 0

    old_system_max_number = 49
    old_system_slot_count = 6
    old_system_try_count = 0
    old_system_matched_count = 0

    match_count = 5
    start = time.perf_counter()

    old_system_numbers = generate_lotery_numbers(
        old_system_slot_count, 1, old_system_max_number)
    new_system_numbers = generate_lotery_numbers(
        new_system_slot_count, 1, new_system_max_number)
    print("Old System Numbers : ", old_system_numbers)
    print("New System Numbers : ", new_system_numbers)

    new_system_week_result = generate_lotery_numbers(
        new_system_slot_count, 1, new_system_max_number)
    new_system_matched_count = get_matched_count(
        new_system_numbers, new_system_week_result)
    while (new_system_matched_count < match_count):
        new_system_try_count += 1
        new_system_week_result = generate_lotery_numbers(
            new_system_slot_count, 1, new_system_max_number)
        new_system_matched_count = get_matched_count(
            new_system_numbers, new_system_week_result)

    old_system_week_result = generate_lotery_numbers(
        old_system_slot_count, 1, old_system_max_number)
    old_system_matched_count = get_matched_count(
        old_system_numbers, old_system_week_result)

    while (old_system_matched_count < match_count):
        old_system_try_count += 1
        old_system_week_result = generate_lotery_numbers(
            old_system_slot_count, 1, old_system_max_number)
        old_system_matched_count = get_matched_count(
            old_system_numbers, old_system_week_result)

    print("Old system try count: ", old_system_try_count)
    print("New system try count: ", new_system_try_count)
    end = time.perf_counter()
    print("Time : ", end - start)
