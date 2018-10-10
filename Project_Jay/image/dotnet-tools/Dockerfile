FROM microsoft/aspnetcore

RUN apt-get update \
    && apt-get install -y wget gpg

WORKDIR /

COPY entrypoint.sh /
RUN chmod +x ./entrypoint.sh

RUN wget -qO- https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.asc.gpg \
    && mv microsoft.asc.gpg /etc/apt/trusted.gpg.d/ \
    && wget -q https://packages.microsoft.com/config/debian/9/prod.list \
    && mv prod.list /etc/apt/sources.list.d/microsoft-prod.list \
    && chown root:root /etc/apt/trusted.gpg.d/microsoft.asc.gpg \
    && chown root:root /etc/apt/sources.list.d/microsoft-prod.list

RUN apt-get install -y apt-transport-https

RUN apt-get update \
    && apt-get install -y dotnet-sdk-2.1

CMD ["./entrypoint.sh"]