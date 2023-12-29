import os


# Donwload entries playlist from youtbe using yt_dlp
def get(url: str) -> None:
    """
  Executes a command-line query to download a video from a given URL.

  Args:
      url (str): The URL of the video to download.

  Returns:
      None
  """
    query = f"""yt-dlp --sleep-interval 1 --concurrent-fragments 2 "bestvideo[ext=mp4]+bestaudio[ext=m4a]/bestvideo[ext=webm]+bestaudio[ext=webm]/best" {url}  -o "%(title)s.%(ext)s"""
    os.system(query)
