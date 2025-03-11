import React, { useEffect, useRef } from 'react';

const AudioCall = () => {
  const localAudioRef = useRef<HTMLAudioElement>(null);
  const remoteAudioRef = useRef<HTMLAudioElement>(null);

  useEffect(() => {
    const startCall = async () => {
      const localStream = await navigator.mediaDevices.getUserMedia({ audio: true });
      if (localAudioRef.current) {
        localAudioRef.current.srcObject = localStream;
      }

      // Set up WebRTC connection here
      // Send audio stream to backend via WebSockets
    };

    startCall();
  }, []);

  return (
    <div>
      <audio ref={localAudioRef} autoPlay muted />
      <audio ref={remoteAudioRef} autoPlay />
    </div>
  );
};

export default AudioCall;