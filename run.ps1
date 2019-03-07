Param([string]$stage)

if ($env:INFINITE_SLEEP -eq 1) {
  if ($stage -ne "install") {
    echo "Sleeping for 200 minutes y'all"
    $i=0
    while ($i -lt 200 ) {
      echo "$i minutes passed"
      $i++
      sleep 60
    }
    echo "Awoke!"
  }  
  else {echo "skipping timeout on the install phase"}
}

elseif ($env:INFINITE_SLEEP -eq 2) {
  echo "Sleeping for 100 minutes y'all"
  $i=0
  while ($i -lt 200 ) {
    echo "$i minutes passed"
    $i++
    sleep 60
  }
  echo "Awoke!"
}

elseif ($env:INFINITE_SLEEP -eq 3) {    
  while ($true) {
    echo "foo"
    sleep 60
  }    
}
