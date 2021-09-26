#!/usr/bin/env bash

set -euo pipefail
RESET="\033[0m"
YELLOW="\033[0;33m"

__warn() {
  echo -e "${YELLOW}warning: $*${RESET}"
  if [ -n "${TF_BUILD:-}" ]; then
    echo "##vso[task.logissue type=warning]$*"
  fi
}

ulimit -c unlimited

if [ -e /proc/self/coredump_filter ]; then
  if [ -w /proc/self/coredump_filter ]; then
    # On Alpine image, writing to coredump_filter causes an error _despite_ updating the file.
    echo 0x3f >/proc/self/coredump_filter || true
  else
    __warn "/proc/self/coredump_filter exists but is not writeable."
  fi
else
  __warn "/proc/self/coredump_filter file not found."
fi
