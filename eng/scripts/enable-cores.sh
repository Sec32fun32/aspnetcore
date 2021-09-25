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
    ls -l /proc/self/coredump_filter
  fi
  echo "/proc/self/coredump_filter:"
  cat /proc/self/coredump_filter
  echo ""
else
  __warn "/proc/self/coredump_filter file not found."
fi

if [ -r /proc/sys/kernel/core_pattern ]; then
  echo "/proc/sys/kernel/core_pattern:"
  cat /proc/sys/kernel/core_pattern
  echo ""
fi

if [ -r /etc/default/apport ]; then
  echo "/etc/default/apport:"
  cat /etc/default/apport
  echo ""

  if [ -r /etc/apport/crashdb.conf ]; then
    echo "/etc/apport/crashdb.conf:"
    cat /etc/apport/crashdb.conf
    echo ""
  fi

  if command -V systemctl; then
    if pidof systemctl; then
      systemctl status || __warn "systemctl: disabled."
      systemctl status apport || __warn "systemctl: apport disabled."
      echo ""
    else
      __warn "systemctl command exists but service isn't running."
    fi
  else
    __warn "systemctl command does not exist."
  fi

  if command -V service; then
    service --status-all
  else
    __warn "service command does not exist."
  fi
fi
