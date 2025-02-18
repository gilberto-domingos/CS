import random
import pyperclip
import subprocess
# code ~/.zshrc


def generate_random_number():
    return str(random.randint(10000, 99999))


def get_last_commit_ticket():
    try:
        # Command to get the message of the last commit
        last_commit_message = subprocess.check_output(
            ["git", "log", "-1", "--pretty=%B"]).strip().decode("utf-8")

        # Checks if the last commit message contains a ticket number
        if "#" in last_commit_message:
            # Extract the ticket number from the last commit
            last_commit_ticket = last_commit_message.split("#")[-1].split()[0]

            # Remove any non-numeric characters from the ticket number
            last_commit_ticket = ''.join(
                filter(str.isdigit, last_commit_ticket))

            return int(last_commit_ticket)
        else:
            print("There is no other commit number")
            return generate_random_number()
    except subprocess.CalledProcessError:
        print("No commits found in the repository.")
        return None


if __name__ == '__main__':
    random_number = generate_random_number()
    last_commit_ticket = get_last_commit_ticket()

    if last_commit_ticket is not None:
        next_commit_ticket = int(last_commit_ticket) + 1
        output = f"Last Commit: (#{last_commit_ticket}) New Commit: (#{
            next_commit_ticket})"
        pyperclip.copy(f"(#{next_commit_ticket})")
    else:
        output = f"(#{random_number})"
        pyperclip.copy(output)

    print(output)
